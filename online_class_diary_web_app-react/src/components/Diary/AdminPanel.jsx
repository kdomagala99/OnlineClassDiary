import styled from "styled-components";
import Context from "../../store/context";
import { useContext } from "react";

const AdminPanel = () => {
  const ctx = useContext(Context);
  return (
    <>
      <Footer show={ctx.isVisible}>
        <button>Add Grade</button>
        <button>Edit Grade</button>
        <button>Delete Grade</button>
      </Footer>
    </>
  );
};

const Footer = styled.footer`
  position: absolute;
  bottom: 0;
  width: 100%;
  height: 5rem;
  background-color: rgb(247, 240, 231);
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.26);
  display: flex;
  align-items: center;
  justify-content: space-around;
  transform: ${({ show }) => (show ? "translateY(0%)" : "translateY(100%)")};
  transition: all 0.3s ease;

  button {
    padding: 0.6rem;
    outline: none;
    border: none;
    background-color: transparent;
    color: rgb(240, 165, 68);
    font-weight: bold;
    cursor: pointer;
  }
`;

export default AdminPanel;
