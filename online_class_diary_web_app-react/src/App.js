import LoginPage from "./pages/LoginPage";
import DiaryPage from "./pages/DiaryPage";
import NotFound from "./pages/NotFound";

import CalendarPage from "./pages/CalendarPage";
import GlobalStyles from "./styles/Global";
import { Route, Navigate, Routes } from "react-router-dom";
import ContactPage from "./pages/ContactPage";
import AttendancePage from "./pages/AttendancePage";

function App() {
  return (
    <>
      <GlobalStyles />
      <Routes>
        <Route path="/" element={<Navigate to="/login" />} />
        <Route path="/login" element={<LoginPage />} />
        <Route path="/login/diary" element={<DiaryPage />} />
        <Route path="/login/diary/contact" element={<ContactPage />} />
        <Route path="/login/diary/attendance" element={<AttendancePage />} />
        <Route path="/login/diary/calendar" element={<CalendarPage />} />
        <Route path="*" element={<NotFound />} />
      </Routes>
    </>
  );
}

export default App;
