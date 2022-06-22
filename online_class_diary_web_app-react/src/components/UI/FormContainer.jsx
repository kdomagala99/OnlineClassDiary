import styled from "styled-components";

const FormContainer = ({ children, show, send }) => {
  return (
    <Form show={show} onSubmit={send}>
      {children}
    </Form>
  );
};

const Form = styled.form`
  width: 20rem;
  padding: 1.5rem;
  position: absolute;
  top: 57%;
  left: 10%;
  border-radius: 5px;
  transform: translate(-50%, -50%);
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  box-shadow: 0 2px 8px rgba(0, 0, 0, 0.26);
  background-color: rgb(247, 240, 231);
  opacity: ${({ show }) => (show ? "1" : "0")};
  pointer-events: ${({ show }) => (show ? "full" : "none")};
  transition: all 0.3s ease;

  label {
    color: rgb(240, 165, 68);
    font-weight: bold;
  }

  input {
    outline: none;
    border: none;
    border: 1px solid rgb(231, 186, 126);
    padding: 0.2rem;
    margin: 1rem 0rem;
  }

  button {
    padding: 0.25rem 0.5rem;
    border-radius: 3px;
    background-color: rgb(240, 165, 68);
    border: none;
    color: rgb(255, 255, 255);
    cursor: pointer;
  }
  p {
    margin-top: 2rem;
    color: ${({ gradeStatus }) =>
      gradeStatus === "success" ? "rgb(28, 170, 28)" : "firebrick"};
  }
`;
export default FormContainer;
