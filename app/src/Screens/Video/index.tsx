import React, {useState, useContext, useEffect} from 'react';
import {Dimensions} from 'react-native';
import Styled from 'styled-components/native';
import {RouteProp} from '@react-navigation/native';
import {RNCamera} from 'react-native-camera';

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
    const cameraRef = React.useRef(null);
    return (
        <>
            <RNCamera
              ref={cameraRef}
              type={RNCamera.Constants.Type.front}
              style={{
                width: Dimensions.get("window").width,
                height: Dimensions.get("window").height,
              }}
              captureAudio={true} />
        </>
    );
};

export default Video;