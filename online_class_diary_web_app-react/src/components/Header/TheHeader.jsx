import styled from "styled-components";
import { NavLink } from "react-router-dom";
import Context from "../../store/context";
import { useContext } from "react";

const TheHeader = () => {
  const ctx = useContext(Context);
  const userInfo = JSON.parse(sessionStorage.getItem("sessionObj"));

  return (
    <Header>
      {(userInfo.role === "Teacher" || userInfo.role === "Student") && (
        <NavLink show={ctx.student} to="/login/diary/attendance">
          Attendance
        </NavLink>
      )}
      <h1>E - Diary</h1>
      {(userInfo.role === "Teacher" || userInfo.role === "Student") && (
        <NavLink to="/login/diary/calendar">Calendar</NavLink>
      )}
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

  a {
    margin: 0rem 15rem;
    text-decoration: none;
    color: rgb(233, 186, 125);
    font-weight: bold;
  }
`;

export default TheHeader;
