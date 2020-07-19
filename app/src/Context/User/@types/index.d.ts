interface IUserInfo {
    name: string;
    email: string;
}

interface IUserContext {
    isLoading: boolean;
    isLinked: boolean;
    userInfo: IUserInfo;
    login: (email: string, password: string) => void;
    link: (email: string) => void;
    getUserInfo: () => void;
    logout: () => void;
}

type LoginNaviParamList = {
    Login: undefined;
};