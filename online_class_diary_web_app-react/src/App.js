import LoginPage from "./pages/LoginPage";
import DiaryPage from "./pages/DiaryPage";
import NotFound from "./pages/NotFound";
import GlobalStyles from "./styles/Global";
import { Route, Navigate, Routes } from "react-router-dom";

function App() {
  return (
    <>
      <GlobalStyles />
      <Routes>
        <Route path="/" element={<Navigate to="/login" />} />
        <Route path="/login" element={<LoginPage />} />
        <Route path="/login/diary" element={<DiaryPage />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
    </>
  );
}

export default App;
