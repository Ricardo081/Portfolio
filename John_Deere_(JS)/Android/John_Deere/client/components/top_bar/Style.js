import { StyleSheet, Dimensions } from "react-native";

const styles = StyleSheet.create({
    container:{
        position:'absolute',
        top: 50,
        zIndex: 100,
        flexDirection: 'row',
        justifyContent: 'space-between',
        width: '100%',
        paddingRight: 15,
        // paddingHorizontal: 10,
    },
    logo:{
        width: 200,
        height: 40,
        resizeMode: 'contain'
    },
    menu:{
        width: 30,
        height: 30,
        resizeMode: 'contain'

    }
})
export default styles