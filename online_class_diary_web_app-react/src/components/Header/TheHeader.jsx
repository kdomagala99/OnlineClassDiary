import styled from "styled-components";

const TheHeader = () => {
  return (
    <Header>
      <h1>E - Diary</h1>
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
`;

export default TheHeader;
