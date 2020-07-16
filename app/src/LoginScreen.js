import React, { Component } from 'react';
import {
  View,
  Text,
  TextInput,
  TouchableOpacity,
  StyleSheet
} from 'react-native';
import { widthPercentageToDP as wp, heightPercentageToDP as hp } from 'react-native-responsive-screen';

export default class LoginScreen extends Component {

  static navigationOptions = {
    header: null,
  };

  _doLogin() {
    // 로그인 버튼 눌렀을 때
    alert('로그인 시도')


    //this.props.navigation.replace('TabNavigator')
  }

  _doSignUp() {
    // 회원가입 버튼 눌렀을 때
    alert('회원가입 시도')
    

    //this.props.navigation.replace('TabNavigator')
  }

  render() {
    return (
      <View style={styles.container}>
        <View style={styles.titleArea}>
          <Text style={styles.title}>아몰랑</Text>
        </View>
        <View style={styles.formArea}>
          <TextInput
            style={styles.textForm}
            placeholder={"ID"} />
          <TextInput
            style={styles.textForm}
            placeholder={"Password"} 
            secureTextEntry={true}
            />
        </View>
        <View style={styles.buttonArea}>
          <TouchableOpacity
            style={styles.loginButton}
            onPress={this._doLogin.bind(this)}>
            <Text style={styles.buttonTitle}>Login</Text>
          </TouchableOpacity>
          <TouchableOpacity
            style={styles.signUpButton}
            onPress={this._doSignUp.bind(this)}>
            <Text style={styles.buttonTitle}>회원가입</Text>
          </TouchableOpacity>
        </View>


      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'white',
    paddingLeft: wp('10%'),
    paddingRight: wp('10%'),
    justifyContent: 'center',
  },
  titleArea: {
    width: '100%',
    padding: wp('10%'),
    alignItems: 'center',
  },
  title: {
    fontSize: wp('10%'),
  },
  formArea: {
    width: '100%',
    paddingBottom: wp('10%'),
  },
  textForm: {
    borderWidth: 0.5,
    borderColor: '#888',
    width: '100%',
    height: hp('5%'),
    paddingLeft: 5,
    paddingRight: 5,
    marginBottom: 5,
  },
  buttonArea: {
    flexDirection: 'row',
    width: '47%',
    height: hp('5%'),
  },
  loginButton: {
    backgroundColor: "#46c3ad",
    width: "100%",
    height: "100%",
    justifyContent: 'center',
    alignItems: 'center',
  },
  signUpButton: {
    marginLeft: '12%',
    backgroundColor: "#8A1CEA",
    width: "100%",
    height: "100%",
    justifyContent: 'center',
    alignItems: 'center',
  },
  buttonTitle: {
    color: 'white',
  },
})