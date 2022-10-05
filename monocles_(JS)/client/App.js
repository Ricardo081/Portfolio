import { StatusBar } from 'expo-status-bar';
import React from 'react';
import { StyleSheet, Text, View } from 'react-native';
import Top_bar from './components/top_bar/Top_bar';

export default function App() {
  return (
    <View style={styles.container}>

    <Top_bar/>
    {/* <Birds/> */}
      <Text>Hi9</Text>

      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
