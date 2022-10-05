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
                content={"Read More"}
                onPress={() => {
                    console.log('Read More, pressed')
                }}
                />

                <Button 
                type="secondary" 
                content={"Donate"}
                onPress={() => {
                    console.log('Donate, pressed')
                }}
                />
            </View>
        </View>
    )
}

export default Birds
