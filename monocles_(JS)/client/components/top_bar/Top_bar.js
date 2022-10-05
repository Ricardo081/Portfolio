import React from 'react'
import {View,Image} from 'react-native'
import styles from './Style'

function Top_bar() {
    return (
        <View style={styles.container}>
            <Image style={styles.logo} source={require('../../assets/logo/monocles_name.png')}/>
            <Image style={styles.menu} source={require('../../assets/logo/menu-bar.png')}/>
        </View>
    )
}

export default Top_bar