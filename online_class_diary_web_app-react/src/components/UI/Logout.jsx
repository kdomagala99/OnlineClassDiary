import styled from "styled-components";
import { useNavigate } from "react-router-dom";
const Logout = () => {
  const navigate = useNavigate();

  const endSession = () => {
    sessionStorage.clear();
    navigate("/");
  };

  return <LogoutButton onClick={endSession}>Logout</LogoutButton>;
};

const LogoutButton = styled.button`
  color: rgb(233, 186, 125);
  position: absolute;
  top: 5%;
  left: 3%;
  padding: 0.4rem 1rem;
  outline: none;
  background-color: transparent;
  border-radius: 10px;
  border: none;
  box-shadow: 0px 1px 3px rgba(0, 0, 0, 0.26);
  font-weight: bold;
  cursor: pointer;
  transition: all 0.3s ease;

  &:hover {
    box-shadow: 0px 1px 10px rgba(0, 0, 0, 0.26);
  }
`;

export default Logout;
