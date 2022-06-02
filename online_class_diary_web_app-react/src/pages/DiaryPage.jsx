import TheHeader from "../components/Header/TheHeader";
import TheTable from "../components/Diary/TheTable";
import AdminPanel from "../components/Diary/AdminPanel";
import AdminButton from "../components/Diary/AdminButton";

const DiaryPage = () => {
  return (
    <>
      <TheHeader />
      <TheTable />
      <AdminPanel />
      <AdminButton />
    </>
  );
};

export default DiaryPage;
