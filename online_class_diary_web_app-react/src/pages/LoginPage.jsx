import styled from "styled-components";
import { useNavigate } from "react-router-dom";

const LoginPage = () => {
  const navigate = useNavigate();

  const goMainPage = (e) => {
    e.preventDefault();
    return navigate("/login/diary");
  };

  return (
    <Wrapper>
      <Form>
        <h1>E - Diary</h1>
        <DataFields>
          <div>
            <input type="text" autoComplete="off" id="username" required />
            <Label htmlFor="username">
              <span>Username</span>
            </Label>
          </div>
          <div>
            <input type="text" autoComplete="off" id="password" required />
            <Label htmlFor="password">
              <span>Password</span>
            </Label>
          </div>
        </DataFields>
        <button onClick={goMainPage}>Login</button>
      </Form>
    </Wrapper>
  );
};

const Wrapper = styled.main`
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  background: rgb(247, 240, 231);
`;

const Form = styled.form`
  width: 25rem;
  height: 40rem;
  background: rgb(255, 255, 255);
  box-shadow: 0px 2px 8px rgba(0, 0, 0, 0.26);
  display: flex;
  align-items: center;
  justify-content: space-around;
  flex-direction: column;

  h1 {
    color: rgb(233, 186, 125);
  }

  button {
    margin-bottom: 2.5rem;
    width: 80%;
    padding: 0.6rem;
    cursor: pointer;
    outline: none;
    border: none;
    background-color: rgb(233, 186, 125);
    color: rgb(255, 255, 255);
    font-weight: bold;
  }

  button:hover {
    background-color: rgba(233, 186, 125, 0.7);
  }
`;

const DataFields = styled.div`
  width: 80%;

  & > div {
    height: 3rem;
    width: 100%;
    margin: 3rem 0rem;
    position: relative;
    overflow: hidden;
  }

  & > div input {
    width: 100%;
    height: 100%;
    outline: none;
    padding-top: 20px;
    border: none;
  }

  & > div input:focus + label span,
  & > div input:valid + label span {
    transform: translateY(-150%);
    font-size: 14px;
    color: rgb(233, 186, 125);
  }

  & > div input:focus + label::after,
  & > div input:valid + label::after {
    transform: translateX(0);
  }
`;

const Label = styled.label`
  position: absolute;
  left: 0;
  top: 0;
  width: 100%;
  height: 100%;
  pointer-events: none;
  border-bottom: 1px solid grey;

  &::after {
    content: "";
    position: absolute;
    bottom: -1px;
    left: 0px;
    height: 100%;
    width: 100%;
    border-bottom: 3px solid rgb(233, 186, 125);
    transform: translateX(-100%);
    transition: transform 0.3s ease;
  }
  span {
    position: absolute;
    bottom: 5px;
    left: 0;
    color: rgb(128, 128, 128);
    transition: all 0.3s ease;
  }
`;

export default LoginPage;
