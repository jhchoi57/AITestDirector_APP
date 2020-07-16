import React from 'react';
import Styled from 'styled-components/native';

const Container = Styled.View`
    width: 100%;
    height: 40px;
    padding-left: 16px;
    padding-right: 16px;
    border-radius: 4px;
    background-color: #FFFFFF;
    border: 1px;
    border-color: #333333;
`;

const InputField = Styled.TextInput`
    flex: 1;
    color: #141414;
`;

interface Props {
    placeholder?: string;
    keyboardType?: 'default' | 'email-address' | 'numeric' | 'phone-pad';
    secureTextEntry?: boolean;
    style?: Object;
    clearMode?: boolean;
    onChangeText?: (text: string) => void;
}

const Input = ({
    placeholder,
    keyboardType,
    secureTextEntry,
    clearMode,
    style,
    onChangeText,
}: Props) => {
    return (
        <Container style={style}>
            <InputField
                selectionColor="#FFFFFF"
                secureTextEntry={secureTextEntry}
                keyboardType={keyboardType ? keyboardType : 'default'}
                autoCapitalize="none"
                autoCorrect={false}
                allowFontScaling={false}
                placeholderTextColor="#141414"
                placeholder={placeholder}
                clearButtonMode={clearMode ? 'while-editing' : 'never'}
                onChangeText={onChangeText}
            />
        </Container>
    );
};

export default Input;