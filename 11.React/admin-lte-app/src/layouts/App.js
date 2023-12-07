import { Outlet } from "react-router-dom";
import ControlSidebar from "./ControlSidebar";
import Footer from "./Footer";
import MainHeader from "./MainHeader";
import MainSidebar from "./MainSidebar";
import Preloader from "./Preloader";

export default function App() {
  return (
    <>
      <div className="wrapper">
        <Preloader/>
        <MainHeader/>
        <MainSidebar/>

        <Outlet/>
        
       <Footer/>
        <ControlSidebar/>
      </div>

    </>
  );
}
