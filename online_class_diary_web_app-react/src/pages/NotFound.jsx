import styled from "styled-components";

const NotFound = () => {
  return <NotFoundPage>Page not found</NotFoundPage>;
};

const NotFoundPage = styled.h1`
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-50%, -50%);
`;

export default NotFound;
