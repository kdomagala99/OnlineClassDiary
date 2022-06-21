import { createGlobalStyle } from "styled-components";

const GlobalStyles = createGlobalStyle`
    *,*::before,*::after{
        box-sizing: border-box;
        margin: 0;
        padding: 0;
        font-family: 'Roboto', sans-serif;
    }

    body, html, #root{
        background-color: rgb(247, 240, 231);
        min-height: 100vh;
        overflow: hidden;
    }

    #root{
        display: flex;
        flex-direction: column;
    }
`;

export default GlobalStyles;
