import React from 'react';
import Styled from 'styled-components/native';
import Button from '~/Components/Button';

const Container = Styled.View`
    flex: 1;
    background-color: #FFFFFF;
    align-items: center;
    justify-content: center;
`;

const Image = Styled.Image`
    width: 50%;
    height: 50%;
    resizeMode: contain;
`;

const Link = () => {
    return (
        <Container>

            <Image 
                source = {require('~/Image/LinkImage.png')} 
            />

            <Button
                style={{marginBottom: 24}}
                label="PC연동"
                onPress={() => {
                    alert(' PC 연동 버튼 ')
                }}
            />

        </Container>
    );
};

export default Link;