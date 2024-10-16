import React from 'react';
import { Card, Image, Button } from 'semantic-ui-react';
import { Link } from 'react-router-dom';
import { Profile } from '../../app/models/profile';

interface Props {
    profile: Profile;
}

export default function ProfileCard({ profile }: Props) {
    return (
        <Card as={Link} to={`/profiles/${profile.username}`}>
            <Image src={profile.image || '/assets/user.png'} wrapped ui={false} />
            <Card.Content>
                <Card.Header>{profile.displayName}</Card.Header>
                <Card.Meta>{profile.username}</Card.Meta>
            </Card.Content>
            <Card.Content extra>
                <Button basic color='blue'>
                    View Profile
                </Button>
            </Card.Content>
        </Card>
    );
}
