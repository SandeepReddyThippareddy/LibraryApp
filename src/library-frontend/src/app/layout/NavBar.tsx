import {Button, Container, Dropdown, Menu, Image} from "semantic-ui-react";
import { Link, NavLink } from "react-router-dom";
import { observer } from "mobx-react-lite";
import { useStore } from "../../features/store";

export default observer(function NavBar() {
    const {userStore: {user, logout}} = useStore();
    return (
        <Menu inverted fixed='top'>
            <Container>
                <Menu.Item as={NavLink} to='/' header>
                    Home
                </Menu.Item>
                <Menu.Item as={NavLink} to='/books' name='Books' />
                {user?.isLibrarian && (
                    <Menu.Item as={NavLink} to="/books/create" exact>
                    <Button positive>Create Book</Button>
                    </Menu.Item>
                )}
                <Menu.Item position='right'>
                    <Image avatar spaced='right' src={user?.profileImage || '/assets/user.png'} />
                    <Dropdown pointing='top left' text={user?.username}>
                        <Dropdown.Menu>
                            <Dropdown.Item as={Link} to={`/profiles/${user?.username}`} text='My Profile' icon='user' />
                            <Dropdown.Item onClick={logout} text='Logout' icon='power' />
                        </Dropdown.Menu>
                    </Dropdown>
                </Menu.Item>
            </Container>
        </Menu>
    )
})
