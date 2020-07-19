import React, {useState, useContext, useEffect} from 'react';
import {Dimensions} from 'react-native';
import Styled from 'styled-components/native';
import {RouteProp} from '@react-navigation/native';


const View = Styled.View`
    flex: 1;
    justify-content: center;
    align-items: center;
`;

const TextEx = Styled.Text`
    font-size: 12px;
`;

type VideoRouteProp = RouteProp<NaviParamList, 'Video'>;

interface Props {
    route: VideoRouteProp;
}

const Video = ({route}: Props) => {

    return (
        <>
            <TextEx>비디오 입니다.</TextEx>
        </>
    );
};

export default Video;