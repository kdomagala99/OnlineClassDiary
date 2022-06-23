import axios from "axios";

const api = () => {
  const baseUrl = "https://api-e-class-diary.azurewebsites.net/api";
  let configAxios = {
    headers: {
      "Content-Type": "multipart/form-data",
    },
  };

  return {
    getSubjects: () => axios.get(`${baseUrl}/Subject/getsubjects`),
    addSubject: (subjectName) =>
      axios.post(
        `${baseUrl}/Subject/createsubject`,
        {
          name: subjectName,
        },
        configAxios
      ),
    addGrade: (name, surname, subject, teacher, grade) =>
      axios.post(
        `${baseUrl}/Grade/addgradetostudent`,
        {
          name: name,
          surname: surname,
          value: grade,
          subject: subject,
          teacherEmail: teacher,
        },
        configAxios
      ),
    getGrades: (name, surname) =>
      axios.get(`${baseUrl}/Grade/studentgrades/${name}/${surname}`),
    checkLoginCredentials: (email, password) =>
      axios.post(`${baseUrl}/User/login`, { email, password }, configAxios),

    getUserInfo: (email) => axios.get(`${baseUrl}/User/getuser/${email}`),

    addUser: (email, password, name, surname, role) =>
      axios.post(
        `${baseUrl}/User/adduser`,
        {
          email,
          password,
          name,
          surname,
          role,
        },
        configAxios
      ),

    getAllUsers: () => axios.get(`${baseUrl}/User/getallusers`),
  };
};

export const apiService = api();
