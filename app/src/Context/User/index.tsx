import React, {createContext, useState, useEffect} from 'react';
import AsyncStorage from '@react-native-community/async-storage';

const defaultContext: IUserContext = {
    isLoading: false,
    userInfo: undefined,
    login: (email: string, password: string) => {},
    getUserInfo: () => {},
    logout: () => {},
};

const UserContext = createContext(defaultContext);

interface Props {
    children: JSX.Element | Array<JSX.Element>;
}

const UserContextProvider = ({children}: Props) => {
    const [userInfo, setUserInfo] = useState<IUserInfo | undefined>(undefined);
    const [isLoading, setIsLoading] = useState<boolean>(false);

    const login = (email: string, password: string): void => {
        fetch('http://1.229.246.93:8080/app/login', {
            method: 'POST',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                id: email,
                pw: password
            })
        })
        .then((response) => response.json())
        .then((json) => {
            
            AsyncStorage.setItem('token', json.token).then(() => {
                setUserInfo({
                    name: json.name,
                    email: json.email,
                });
                setIsLoading(true);
            });
            
        })
        .catch(error => {
            console.log(error);
        });
    };

    const getUserInfo = (): void => {
        AsyncStorage.getItem('token')
            .then(value => {
                fetch('http://1.229.246.93:8080/app/token', {
                    method: 'POST',
                    headers: {
                        Accept: 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify({
                        value: value
                    })
                })
                .then((response) => response.json())
                .then((json) => {
                    setIsLoading(true);
                })
                .catch(error => {
                    console.log(error);
                });
            })
            .catch(() => {
                setUserInfo(undefined);
                setIsLoading(true);
            });
    };

    const logout = (): void => {
        AsyncStorage.removeItem('token');
        setUserInfo(undefined);
    };

    useEffect(() => {
        getUserInfo();
    }, []);

    return (
        <UserContext.Provider
            value={{
                isLoading,
                userInfo,
                login,
                getUserInfo,
                logout,
            }}>
            {children}
        </UserContext.Provider>
    );
};

export {UserContextProvider, UserContext};