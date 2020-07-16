import React, { useContext } from 'react';
import {NavigationContainer} from '@react-navigation/native';
import {createStackNavigator} from '@react-navigation/stack';

import {UserContext} from '~/Context/User';

import Loading from '~/Screens/Loading';

import Login from '~/Screens/Login';

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

export default () => {
    const {isLoading, userInfo} = useContext<IUserContext>(UserContext);

    console.log(isLoading);
    console.log(userInfo);

    if(isLoading === false) {
        return <Loading />;
    }
    return (
        <NavigationContainer>
            {userInfo ? <LoginNavigator /> : <LoginNavigator />}
        </NavigationContainer>
    );
};