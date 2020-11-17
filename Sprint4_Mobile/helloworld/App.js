import { StatusBar } from 'expo-status-bar';
import React, {useState} from 'react';
import { StyleSheet, Text, View, TextInput, Button } from 'react-native';

export default function App() {
  
  const [email, setEmail] = useState('');
  const [senha, setSenha] = useState('');

  const logar = () => {
    alert(`${email} ${senha}`);
  }


  return (
    <View style={styles.container}>
      <Text>Fernando Araujo</Text>
      <Text>Hello World</Text>

      <Text>Email</Text>
      <TextInput 
        style={{ height: 40, width: 200, borderColor: 'gray', borderWidth: 1 }}
        //React onChange={event => setEmail(event.target.value)}
        //Vantagem, receber o valor direto sem precisar chamar *event.target.value
        onChangeText={text => setEmail(text)}
        value={email} />

      <Text>Senha</Text>
      <TextInput 
        style={{ height: 40, width: 200, borderColor: 'gray', borderWidth: 1 }}
        //React onChange={event => setEmail(event.target.value)}
        //Vantagem, receber o valor direto sem precisar chamar *event.target.value
        onChangeText={text => setSenha(text)}
        secureTextEntry={true}
        value={senha} />

      <Button
        onPress={logar}
        title="Logar"
        color="red"
        accessibilityLabel="Login"
      />

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
