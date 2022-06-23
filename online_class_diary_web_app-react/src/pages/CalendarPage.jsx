import styled from "styled-components";

const CalendarPage = () => {
  return (
    <EventCalendar>
      <div>
        <h1>June 2022</h1>
      </div>

      <ul>
        <li>
          <time datetime="2022-02-01">1</time>
        </li>
        <li>
          <time datetime="2022-02-02">2</time>
        </li>
        <li>
          <time datetime="2022-02-03">3</time>
        </li>
        <li>
          <time datetime="2022-02-04">4</time> <span>Mathematics Exam</span>
        </li>
        <li>
          <time datetime="2022-02-05">5</time>
        </li>
        <li>
          <time datetime="2022-02-06">6</time>
        </li>
        <li>
          <time datetime="2022-02-07">7</time>
        </li>
        <li>
          <time datetime="2022-02-08">8</time>
        </li>
        <li>
          <time datetime="2022-02-09">9</time>
        </li>
        <li>
          <time datetime="2022-02-10">10</time>
          <span> Polish Exam</span>
        </li>
        <li>
          <time datetime="2022-02-11">11</time>
        </li>
        <li>
          <time datetime="2022-02-12">12</time>
        </li>
        <li>
          <time datetime="2022-02-13">13</time>
        </li>
        <li>
          <time datetime="2022-02-14">14</time>
        </li>
        <li>
          <time datetime="2022-02-15">15</time>
        </li>
        <li>
          <time datetime="2022-02-16">16</time>
          <span>Biology Exam</span>
        </li>
        <li>
          <time datetime="2022-02-17">17</time>
        </li>
        <li>
          <time datetime="2022-02-18">18</time>
        </li>
        <li>
          <time datetime="2022-02-19">19</time>
        </li>
        <li>
          <time datetime="2022-02-20">20</time>
        </li>
        <li>
          <time datetime="2022-02-21">21</time>
        </li>
        <li>
          <time datetime="2022-02-22">22</time>
        </li>
        <li>
          <time datetime="2022-02-23">23</time>
        </li>
        <li>
          <time datetime="2022-02-24">24</time>
        </li>
        <li>
          <time datetime="2022-02-25">25</time>
        </li>
        <li>
          <time datetime="2022-02-26">26</time> <span>IT Exam</span>
        </li>
        <li>
          <time datetime="2022-02-27">27</time>
        </li>
        <li>
          <time datetime="2022-02-28">28</time>
        </li>
      </ul>
    </EventCalendar>
  );
};

export default CalendarPage;

const EventCalendar = styled.div`
  width: 90%;
  max-width: 1200px;
  margin: auto;
  box-shadow: 0 2px 20px rgba(0, 0, 0, 0.1);
  border-radius: 5px;
  background: #fff;

  div {
    text-align: center;
    padding: 20px 0;
    color: #51565d;
    background: #f5f7fa;
  }

  li {
    list-style-type: none;
    display: flex;
    flex-flow: column;
    padding: 1em;
    border: 2px solid #51565d;
  }

  span {
    color: #51565d;
    font-weight: bold;
  }

  ul {
    display: grid;
    flex-wrap: wrap;
    list-style: none;
    padding: 0;
    margin: 0;
  }

  @media only screen and (min-width: 946px) {
    ul {
      grid-template-columns: repeat(7, 1fr);
    }

    li:not(:nth-child(7n)) {
      border-right: none;
    }

    li:not(:nth-last-child(-n + 7)) {
      border-bottom: none;
    }
  }

  time {
    font-size: 1.5em;
    margin: 0 0 0.5em 0;
    font-weight: bold;
  }
`;
