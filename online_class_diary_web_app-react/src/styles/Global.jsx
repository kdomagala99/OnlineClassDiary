import { createGlobalStyle } from "styled-components";

const GlobalStyles = createGlobalStyle`
    *,*::before,*::after{
        box-sizing: border-box;
        margin: 0;
        padding: 0;
        font-family: 'Roboto', sans-serif;
    }

    body{
        background-color: rgb(247, 240, 231);
    }

    body,html{
        overflow: hidden;
    }


`;

export default GlobalStyles;
