import styled from "styled-components";
import Context from "../../store/context";
import { useContext } from "react";

const TheHeader = () => {
  const ctx = useContext(Context);

  const endSession = () => {
    sessionStorage.clear();
    ctx.setSession({});
    console.log(ctx.session);
  };

  return (
    <Header>
      <h1>E - Diary</h1>
      <h2 onClick={endSession}>Logout</h2>
    </Header>
  );
};

const Header = styled.header`
  width: 100%;
  padding: 2rem 1rem;
  margin-top: 4rem;
  display: flex;
  color: rgb(233, 186, 125);
  align-items: center;
  justify-content: center;

  h2 {
    cursor: pointer;
    margin-left: 2rem;
  }
`;

export default TheHeader;
