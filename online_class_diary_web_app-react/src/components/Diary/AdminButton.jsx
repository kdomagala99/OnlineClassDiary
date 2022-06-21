import styled from "styled-components";
import { useContext } from "react";
import Context from "../../store/context";

const AdminButton = () => {
  const ctx = useContext(Context);
  return (
    <Button show={ctx.footer} onClick={ctx.footerVisibilityHandler}></Button>
  );
};

const Button = styled.button`
  padding: 1.5rem;
  border-radius: 50%;
  border: none;
  background: rgb(240, 165, 68);
  position: absolute;
  bottom: 3rem;
  right: 3rem;
  outline: none;
  background-image: url(../assets/arrow.svg);
  background-repeat: no-repeat;
  background-position: 50% 50%;
  cursor: pointer;
  transform: ${({ show }) => (show ? "rotate(-180deg)" : "rotate(0)")};
  transition: transform 0.3s ease;
`;

export default AdminButton;
