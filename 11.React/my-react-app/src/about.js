import { useEffect, useState } from "react";

export function AboutComponent(){
    const [isColorRed, setIsColorRed] = useState(false);

    function changeColor(){
        setIsColorRed((prev)=> !prev);
    }

    function showButton(){
        if(isColorRed){
            return (<button style={{backgroundColor: "red", color:"white"}}>Kırmızı</button>)
        }else{
            return (<button style={{backgroundColor: "blue", color:"white"}}>Mavi</button>)
        }
    }

    return(
        <>
        <h1>About page</h1>
        <button onClick={changeColor}>Rengi Değiştir</button>
        <br />
        {showButton()}
        </>
    )
}