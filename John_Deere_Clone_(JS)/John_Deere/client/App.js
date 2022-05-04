import { StatusBar } from 'expo-status-bar';
import React from 'react';
import { StyleSheet, View} from 'react-native';
import Equipment_List from './components/equipment_list/Equipment_List';
import Top_bar from './components/top_bar/Top_bar';

export default function App() {
  return (
    <View style={styles.container}>

      <Top_bar/>
      <Equipment_List/>

      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'white',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
