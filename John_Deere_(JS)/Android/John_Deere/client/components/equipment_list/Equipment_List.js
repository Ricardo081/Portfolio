import React from 'react'
import {View, Text, FlatList, Dimensions} from 'react-native'
import Equipment from '../equipment/Equipment'

import styles from './Styles'
import equipment_data from './Equipment_data'


function Equipment_List() {
    return (
        <View style={styles.container}>
            <FlatList
            data={equipment_data}
            renderItem={({item}) => <Equipment equipment={item}/>}
            showsVerticalScrollIndicator={false}
            snapToAlignment={'start'}
            decelerationRate={'fast'}
            snapToInterval={Dimensions.get('window').height}
            />
        </View>
    )
}

export default Equipment_List
