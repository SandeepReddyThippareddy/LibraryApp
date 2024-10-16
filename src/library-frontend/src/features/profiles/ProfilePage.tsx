import React, { useEffect } from 'react';
import { observer } from 'mobx-react-lite';
import { useParams } from 'react-router-dom';
import { Grid, Header, Image, Button } from 'semantic-ui-react';
import LoadingComponent from '../../app/layout/LoadingComponent';
import { useStore } from '../store';

export default observer(function ProfilePage() {
    const { username } = useParams<{ username: string }>();
    const { profileStore } = useStore();
    const { loadProfile, profile, loadingProfile } = profileStore;

    useEffect(() => {
        if (username) loadProfile(username);
    }, [loadProfile, username]);

    if (loadingProfile) return <LoadingComponent content='Loading profile...' />;

    return (
        <Grid>
            <Grid.Column width={16}>
                <Image src={profile?.image || '/assets/user.png'} size='small' circular />
                <Header as='h2'>{profile?.displayName}</Header>
                <Button primary>Edit Profile</Button>
            </Grid.Column>
            <Grid.Column width={16}>
                <Header content='Borrowed Books' />
                {/* Add book list component here */}
            </Grid.Column>
        </Grid>
    );
});
