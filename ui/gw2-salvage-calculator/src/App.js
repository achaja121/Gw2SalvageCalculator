import './App.css';
import { ChakraProvider } from '@chakra-ui/react'
import Header from './components/Header/Header';
import Search from './components/Search/Search';
import ResultCards from './components/ResultCards/ResultCards';

function App() {
  return (
    <div className="App">
      <ChakraProvider>
      <Header/>
      <Search/>
      <ResultCards/>
      </ChakraProvider>
    </div>
  );
}

export default App;
