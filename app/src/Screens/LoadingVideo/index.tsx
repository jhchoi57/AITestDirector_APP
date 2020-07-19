import React, {useContext, useEffect} from 'react';
import {Alert} from 'react-native';
import Styled from 'styled-components/native';
import {StackNavigationProp} from '@react-navigation/stack';
import {RouteProp} from '@react-navigation/native';
import {UserContext} from '~/Context/User';

import Loading from '~/Screens/Loading';

const Container = Styled.View`
    flex: 1;
    background-color: white;
    align-items: center;
    justify-content: center;
`;

type NavigationProp = StackNavigationProp<NaviParamList, 'Loading'>;
type LoadingRouteProp = RouteProp<NaviParamList, 'Loading'>;

interface Props {
    navigation: NavigationProp;
    route: LoadingRouteProp;
}

const LoadingVideo = ({navigation, route}: Props) => {
    const {isLinked} = useContext<IUserContext>(UserContext);

    useEffect(() => {
        setTimeout(() => {
            console.log(isLinked);
            if (isLinked) {
                navigation.navigate('Video');
            } else {    
                Alert.alert('연결 오류', '다시 시도해 보세요.');
                navigation.pop();
            }
        }, 5000);
        console.log(isLinked);
    }, []);

    return (
        <Loading />
    );
};

export default LoadingVideo;