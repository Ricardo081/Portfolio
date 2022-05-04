import { StyleSheet, Dimensions } from "react-native";

const styles = StyleSheet.create({
    equipmentContainer:{
        width:'100%',
        height: Dimensions.get('window').height,
      },
      titlesContainer:{
        marginTop:'30%',
        width: '100%',
        alignItems: 'center',
      },
      title:{
        fontSize: 40,
        fontWeight: '600',
      },
      subtitle:{
        color:'#5c5e62',
        fontSize: 16,
      },
      subtitleCTA:{
        textDecorationLine: 'underline'
      },
      image:{
        width: '100%',
        height: '70%',
        marginTop:'50%',
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