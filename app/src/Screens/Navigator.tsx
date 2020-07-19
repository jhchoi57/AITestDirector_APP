import React, { useContext } from 'react';
import {NavigationContainer} from '@react-navigation/native';
import {createStackNavigator} from '@react-navigation/stack';

import {UserContext} from '~/Context/User';

import Loading from '~/Screens/Loading';
import Login from '~/Screens/Login';
import Link from '~/Screens/Link';
import Video from '~/Screens/Video';
import LoadingVideo from '~/Screens/LoadingVideo';

const Stack = createStackNavigator();

const LoginNavigator = () => {
    return (
        <Stack.Navigator>
            <Stack.Screen
                name="Login"
                component={Login}
                options={{
                    title: 'TestApp',
                    headerTransparent: true,
                    headerTintColor: '#333333',
                    headerTitleStyle: {
                        fontWeight: 'bold',
                    },
                }}
            />
        </Stack.Navigator>
    );
};

const LinkNavigator = () => {
    return (
        <Stack.Navigator>
            <Stack.Screen
                name = "Link"
                component = {Link}
                options={{
                    title: 'PC 연동',
                    headerTitleAlign: "center",
                    headerTransparent: true,
                    headerTintColor: '#333333',
                    headerTitleStyle: {
                        fontWeight: 'bold',
                    },
                }}
            />
            <Stack.Screen
                name = "Loading"
                component = {LoadingVideo}
                options={{
                    title: 'Loading',
                    headerTitleAlign: "center",
                    headerTransparent: true,
                    headerTintColor: '#333333',
                    headerTitleStyle: {
                        fontWeight: 'bold',
                    },
                }}
            />
            <Stack.Screen
                name = "Video"
                component = {Video}
                options={{
                    title: 'Video',
                    headerTitleAlign: "center",
                    headerTransparent: true,
                    headerTintColor: '#333333',
                    headerTitleStyle: {
                        fontWeight: 'bold',
                    },
                }}
            />
        </Stack.Navigator>
    );
};

export default () => {
    const {isLoading, userInfo} = useContext<IUserContext>(UserContext);

    if(isLoading === false) {
        return <Loading />;
    }
    return (
        <NavigationContainer>
            {
            userInfo.email !== '' ? <LinkNavigator/> : <LoginNavigator />
            // <LinkNavigator/>
            }

        </NavigationContainer>
    );
};