import { StyleSheet, Dimensions } from "react-native";

const styles = StyleSheet.create({
    birdContainer:{
        width:'100%',
        height: Dimensions.get('window').height,
      },
      titlesContainer:{
        marginTop:'30%',
        width: '100%',
        alignItems: 'center',
      },
      title:{
        fontSize: 50,
        textAlign: "center",
        fontWeight: '450',
        color: "#f2e4e0"
      },
      // subtitle:{
      //   color:'#f6b89e',
      //   fontSize: 16,
      // },
      subtitleCTA:{
        textDecorationLine: 'underline'
      },
      image:{
        width: '100%',
        height: '100%',
        // marginTop:'50%',
        // resizeMode: 'cover',
        position: 'absolute',
      },
      buttonContainer:
      {
          position: 'absolute',
          bottom: 50,
          width: '100%',
      }
})
export default styles