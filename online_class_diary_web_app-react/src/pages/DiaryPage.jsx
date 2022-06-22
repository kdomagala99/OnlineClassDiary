import TheHeader from "../components/Header/TheHeader";
import TheTable from "../components/Diary/TheTable";
import AdminPanel from "../components/Diary/AdminPanel";
import AdminButton from "../components/Diary/AdminButton";
import AddSubject from "../components/Diary/AddSubject";
import Logout from "../components/UI/Logout";
import LogInfo from "../components/UI/LogInfo";
import AddGrade from "../components/Diary/AddGrade";

const DiaryPage = () => {
  const userInfo = JSON.parse(sessionStorage.getItem("sessionObj"));
  return (
    <>
      <TheHeader />
      <LogInfo />
      <TheTable />
      <AddSubject />
      <AddGrade />
      <AdminPanel />
      {userInfo.name === "Teacher" && <AdminButton />}
      <Logout />
    </>
  );
};

export default DiaryPage;
