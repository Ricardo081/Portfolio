import React from 'react'
import {View, Text, FlatList, Dimensions} from 'react-native'
import Birds from '../../main/Birds'

import styles from './Style'
import Birds_List_data from './Birds_List_data'


function Birds_List() {
    return (
        <View style={styles.container}>
            <FlatList
            data={Birds_List_data}
            renderItem={({item}) => <Birds bird={item}/>}
            showsVerticalScrollIndicator={false}
            snapToAlignment={'start'}
            decelerationRate={'fast'}
            snapToInterval={Dimensions.get('window').height}
            />
        </View>
    )
}

export default Birds_List