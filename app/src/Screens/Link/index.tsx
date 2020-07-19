import React, {useContext} from 'react';
import {Alert} from 'react-native';
import {StackNavigationProp} from '@react-navigation/stack';
import Styled from 'styled-components/native';
import Button from '~/Components/Button';
import {UserContext} from '~/Context/User';

import Loading from '~/Screens/Loading';

const Container = Styled.View`
    flex: 1;
    background-color: #FFFFFF;
    align-items: center;
    justify-content: center;
`;

const FormContainer = Styled.View`
    width: 100%;
    padding: 40px;
`;

const Image = Styled.Image`
    left: 15%;
    right: 15%;
    width: 70%;
    height: 70%;
    align-items: center;
    justify-content: center;
    resizeMode: contain;
`;

type NavigationProp = StackNavigationProp<NaviParamList, 'Link'>;

interface Props {
    navigation: NavigationProp;
}

const Link = ({navigation}: Props) => {
    const {link, userInfo} = useContext<IUserContext>(UserContext);

    return (
        <Container>
            <FormContainer>
                <Image 
                    source = {require('~/Image/LinkImage.png')} 
                />

                <Button
                    style={{marginBottom: 24}}
                    label="PC연동"
                    onPress={() => {
                        link(userInfo.email);
                        navigation.navigate('Loading');
                    }}
                />
            </FormContainer>
        </Container>
    );
};

export default Link;