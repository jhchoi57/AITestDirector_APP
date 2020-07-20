import React, {createContext, useState, useEffect} from 'react';
import AsyncStorage from '@react-native-community/async-storage';

const defaultContext: IUserContext = {
    isLoading: false,
    isLinked: false,
    userInfo: {email:'', name: ''},
    login: (email: string, password: string) => {},
    link: (email:string) => {},
    getUserInfo: () => {},
    logout: () => {},
};

const UserContext = createContext(defaultContext);

interface Props {
    children: JSX.Element | Array<JSX.Element>;
}

const UserContextProvider = ({children}: Props) => {
    const [userInfo, setUserInfo] = useState<IUserInfo>({email: '', name: ''});
    const [isLoading, setIsLoading] = useState<boolean>(false);
    const [isLinked, setIsLinked] = useState<boolean>(true);
    const IP = '58.122.109.234';
    const PORT = 8080;

    const login = (email: string, password: string): void => {
        fetch('http://' +  IP + ':' + PORT + '/app/login', {
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

    const link = (email: string): void => {
        console.log(email);
        fetch('http://' +  IP + ':' + PORT + '/app/link', {
            method: 'POST',
            headers: {
                Accept: 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                email: email,
            })
        })
        .then((response) => response.json())
        .then((json) => {
            setIsLinked(true);
        })
        .catch(error => {
            console.log(error);
        });
    }

    const getUserInfo = (): void => {
        AsyncStorage.getItem('token')
            .then(value => {
                fetch('http://' +  IP + ':' + PORT + '/app/token', {
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
                    setUserInfo({
                        name: json.name,
                        email: json.email,
                    });
                    setIsLoading(true);
                })
                .catch(error => {
                    console.log(error);
                });
            })
            .catch(() => {
                setUserInfo({email: '', name: ''});
                setIsLoading(true);
            });
    };

    const logout = (): void => {
        AsyncStorage.removeItem('token');
        setUserInfo({email: '', name: ''});
    };

    useEffect(() => {
        getUserInfo();
    }, []);

    return (
        <UserContext.Provider
            value={{
                isLoading,
                isLinked,
                userInfo,
                login,
                link,
                getUserInfo,
                logout,
            }}>
            {children}
        </UserContext.Provider>
    );
};

export {UserContextProvider, UserContext};