import React from 'react'
import {View, Text, ImageBackground} from 'react-native'
import styles from './Style'
import Button from '../button/Button'

function Birds(props) {
    const {name, tagline, taglineCTA, image} = props.bird;
    
    return (
        <View style={styles.birdContainer}>
            <ImageBackground 
            source={image}
            style={styles.image}
            />
            <View style={styles.titlesContainer}>
                <Text style={styles.title}>{name}</Text>
                <Text style={styles.subtitle}>{tagline}
                    {' '}
                    <Text style={styles.subtitleCTA}>{taglineCTA}</Text>
                </Text>
                

            </View>
            <View style={styles.buttonContainer}>
                <Button 
                type="primary" 
                content={"See More"}
                onPress={() => {
                    console.log('See More, pressed')
                }}
                />

                <Button 
                type="secondary" 
                content={"Existing Inventory"}
                onPress={() => {
                    console.log('Existing Inventory, pressed')
                }}
                />
            </View>
        </View>
    )
}

export default Birds
