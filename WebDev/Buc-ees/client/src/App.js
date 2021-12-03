import './App.css';
import Title from './pages/top_container/Title'
import Left_Container from './pages/left_container/Left_Container'
import Right_Container from './pages/right_container/Right_Container'

function App() {
  return (
    <div className="App">
      <Title/>
      <Left_Container/>
      <Right_Container/>
    </div>
  );
}

export default App;
