import TheHeader from "../components/Header/TheHeader";
import TheTable from "../components/Diary/TheTable";
import AdminPanel from "../components/Diary/AdminPanel";
import AdminButton from "../components/Diary/AdminButton";
import AddSubject from "../components/Diary/AddSubject";
import Logout from "../components/UI/Logout";
import LogInfo from "../components/UI/LogInfo";
import AddGrade from "../components/Diary/AddGrade";
import AddUser from "../components/Diary/AddUser";
import UsersList from "../components/ListOfUsersAndSubjects/UsersList";
import SubjectsList from "../components/ListOfUsersAndSubjects/SubjectsList";
import ContactButton from "../components/UI/ContactButton";

const DiaryPage = () => {
  const userInfo = JSON.parse(sessionStorage.getItem("sessionObj"));
  return (
    <>
      <TheHeader />
      <LogInfo />
      {userInfo.role === "Student" && <TheTable />}
      {userInfo.role === "Administrator" && <AddUser />}
      {userInfo.role === "Teacher" && <UsersList />}
      {userInfo.role === "Teacher" && <SubjectsList />}
      {(userInfo.role === "Teacher" || userInfo.role === "Student") && (
        <ContactButton />
      )}

      <AddSubject />
      <AddGrade />
      <AdminPanel />
      {userInfo.role === "Teacher" && <AdminButton />}
      <Logout />
    </>
  );
};

export default DiaryPage;
