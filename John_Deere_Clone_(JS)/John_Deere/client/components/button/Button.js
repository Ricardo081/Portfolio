import React from 'react'
import {View, Text, Pressable} from 'react-native'
import styles from './Style'

function Button(props) {
    const {type, content, onPress} = props;
    // const type = props.type;
    // const content = props.content;
    // const onPress = props.onPress;

    const backgroundColor = type === 'primary' ? 'darkgreen' : 'gold'
    const textColor = type === 'primary' ? 'gold' : 'darkgreen'

    return (
        <View style={styles.container}>
            <Pressable 
            style={[styles.button,{backgroundColor: backgroundColor}]}
            onPress={() => onPress()}
            >
                <Text style={[styles.text,{color:textColor}]}>{content}</Text>
            </Pressable>
        </View>
    )
}

export default Button
