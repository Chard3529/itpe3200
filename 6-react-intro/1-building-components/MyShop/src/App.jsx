import { BrowserRouter as Router,Routes,Route,Navigate } from 'react-router-dom';
import Container from 'react-bootstrap/Container';

import NavMenu from './shared/NavMenu';
import HomePage from './home/HomePage';
import ItemListPage from './items/ItemListPage';
import './App.css'


function App(){
  return (
    <>
      <NavMenu />
      <Container>
        <Router>
          <Routes>
            <Route path='/' element={<HomePage/>}/>
            <Route path='/items' element={<ItemListPage/>}/>
            <Route path='*' element={<Navigate to='/' replace />}/>
          </Routes>
        </Router>
      </Container>
    </>
  )
};

export default App;

