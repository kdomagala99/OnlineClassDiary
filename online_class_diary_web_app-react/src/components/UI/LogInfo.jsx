import styled from "styled-components";

const LogInfo = () => {
  const userInfo = JSON.parse(sessionStorage.getItem("sessionObj"));

  return (
    <InfoBox>
      <h3>
        Logged as: <span>{userInfo.role} </span>
      </h3>
    </InfoBox>
  );
};

const InfoBox = styled.div`
  padding: 1rem;
  border: 3px solid rgb(240, 165, 68);
  border-radius: 4px;
  position: absolute;
  top: 23%;
  width: 25%;
  color: rgb(233, 186, 125);
  margin: 0rem auto;
  left: 0;
  right: 0;
  display: flex;
  align-items: center;
  justify-content: center;

  span {
    margin-left: 1rem;
    color: firebrick;
  }
`;

export default LogInfo;
