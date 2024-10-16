import { makeAutoObservable, runInAction } from 'mobx';
import { Review } from '../app/models/review';
import agent from '../app/api/agent';

export default class ReviewStore {
    reviewRegistry = new Map<string, Review>(); // Stores reviews with bookId as the key
    selectedReview: Review | null = null;
    loading = false;

    constructor() {
        makeAutoObservable(this);
    }

    // Fetch all reviews for a specific book
    loadReviews = async (bookId: string) => {
        this.loading = true;
        try {
            const reviews = await agent.ReviewApi.list(bookId);
            runInAction(() => {
                this.reviewRegistry.clear();
                reviews.forEach(review => {
                    this.reviewRegistry.set(review.id, review);
                });
                this.loading = false;
            });
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            });
        }
    };

    // Create a new review
    createReview = async (review: Review) => {
        this.loading = true;
        try {
            const newReview = await agent.ReviewApi.create(review);
            runInAction(() => {
                this.reviewRegistry.set(newReview.id, newReview);
                this.loading = false;
            });
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            });
        }
    };

    // Update a review
    updateReview = async (review: Review) => {
        this.loading = true;
        try {
            await agent.ReviewApi.update(review);
            runInAction(() => {
                this.reviewRegistry.set(review.id, review);
                this.selectedReview = review;
                this.loading = false;
            });
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            });
        }
    };

    // Delete a review
    deleteReview = async (id: string) => {
        this.loading = true;
        try {
            await agent.ReviewApi.delete(id);
            runInAction(() => {
                this.reviewRegistry.delete(id);
                this.loading = false;
            });
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            });
        }
    };
}
