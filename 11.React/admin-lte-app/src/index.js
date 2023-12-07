import ReactDOM from 'react-dom/client';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import App from './layouts/App';
import Home from './Home';
import General from './General';
import Login from './Login';


const root = ReactDOM.createRoot(document.getElementById('root'));
root.render(
  <BrowserRouter>
    <Routes>
      <Route path='/' element={<App/>}>
        <Route index element={<Home/>} />
        <Route path='general' element={<General/>} />
      </Route>

      <Route path='login' element={<Login/>} />
    </Routes>
  </BrowserRouter>
);
