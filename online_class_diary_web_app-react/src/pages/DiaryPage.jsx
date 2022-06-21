import TheHeader from "../components/Header/TheHeader";
import TheTable from "../components/Diary/TheTable";
import AdminPanel from "../components/Diary/AdminPanel";
import AdminButton from "../components/Diary/AdminButton";
import AddSubject from "../components/Diary/AddSubject";
import Context from "../store/context";
import { useContext } from "react";

const DiaryPage = () => {
  const ctx = useContext(Context);
  return (
    <>
      <TheHeader />
      <TheTable />
      <AddSubject />
      <AdminPanel />
      {ctx.teacher && <AdminButton />}
    </>
  );
};

export default DiaryPage;
