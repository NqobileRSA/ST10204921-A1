# Cybersecurity Awareness Chatbot — Part 1

## Background

South Africa has seen a significant rise in cyberattacks targeting individuals, businesses, and government institutions. These attacks often include phishing scams, malware, and social engineering, leaving many people vulnerable to financial loss, identity theft, and psychological harm.

In response, the Department of Cybersecurity has launched a campaign aimed at educating citizens on identifying and mitigating cyber threats. You have been tasked with developing a **Cybersecurity Awareness Assistant** — a chatbot that simulates real-life scenarios where users might encounter cyber threats and provides guidance on avoiding common traps.

> **Further reading:** Pieterse, H. 2021. _The Cyber Threat Landscape in South Africa: A 10-Year Review._ The African Journal of Information and Communication, 28(28). doi: [10.23962/10539/32213](https://doi.org/10.23962/10539/32213)

---

## Introduction

This POE consists of three parts, each building on the previous one.

| Part             | Description                                                                                          |
| ---------------- | ---------------------------------------------------------------------------------------------------- |
| **Part 1**       | Command-line chatbot with basic cybersecurity awareness functionality                                |
| **Part 2**       | GUI upgrade using WPF or Windows Forms with topic recognition                                        |
| **Part 3 / POE** | Extended GUI with advanced features, a mini-game or task list, and an 8–10 minute video presentation |

> **Tip:** Review all three parts before starting Part 1 to plan effectively and avoid unnecessary rework.

---

## Important Notes

- **Submission:** Push each part to GitHub and submit the link on Arc.
- **GitHub:** Minimum **six commits** per part, with **CI via GitHub Actions**.
- **Penalty:** -5% per task if not submitted on GitHub.
- **Presentation:** Record an unlisted YouTube video with your own voice-over explaining logic, flow, and a live demo. No AI-generated voices.
- **Marks are awarded for functional, running software** — not source code alone. Ensure the project compiles and your README provides clear setup instructions.

---

## Part 1 — Basic Chatbot Interaction with Voice Greeting and Image

**Total Marks: 100** | Learning Units 1 and 2

### Learning Outcomes

By the end of Part 1, students should be able to:

- Write a console programme that requires user input.
- Apply string manipulation to solve a programming problem.
- Use automatic properties to solve a programming problem.

---

## Tasks

### 1. Voice Greeting `[10 Marks]`

**Objective:** Add a personalised touch by playing a recorded voice greeting on launch.

- Record a short WAV welcome message (e.g., _"Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online."_)
- Save in **WAV format** for compatibility with `System.Media` in C#.
- Play the audio file when the application starts.

---

### 2. Image Display `[10 Marks]`

**Objective:** Enhance visual presentation with ASCII art.

- Create a **Cybersecurity Awareness Bot** logo or cybersecurity-themed symbol using ASCII art.
- Display it as a header or title screen on launch.

---

### 3. Text-Based Greeting and User Interaction `[10 Marks]`

**Objective:** Initiate a welcoming and interactive experience.

- Ask the user for their **name** and personalise all subsequent responses.
- Display a welcome message with ASCII art or decorative borders after the voice greeting.

---

### 4. Basic Response System `[15 Marks]`

**Objective:** Respond to basic cybersecurity-related user questions.

- Provide responses for questions like:
  - "How are you?"
  - "What's your purpose?"
  - "What can I ask you about?"
- Cover topics including: **password safety**, **phishing**, and **safe browsing**.

---

### 5. Input Validation `[5 Marks]`

**Objective:** Handle unexpected or invalid inputs gracefully.

- Detect and respond to empty entries or unsupported queries.
- Provide a default response such as: _"I didn't quite understand that. Could you rephrase?"_

---

### 6. Enhanced Console UI with Visual Elements `[10 Marks]`

**Objective:** Improve the chatbot's appearance using formatting techniques.

- Use **coloured text**, spacing, borders, and symbols to create a visually structured interface.
- Add section headers and dividers for readability.
- Consider a **typing effect** or slight delays to simulate a conversational feel.

---

### 7. Code Structure and Readability `[15 Marks]`

- Structure code clearly across multiple files — **do not write all code in `Program.cs`**.
- Use **methods and classes** for separation of concerns and readability.

---

### 8. GitHub Version Control and CI Implementation `[15 Marks]`

#### Commits

Make a minimum of **six meaningful commits**, each reflecting a significant change. Example messages:

```
Initial commit: Set up project structure and main files.
Added greeting and user interaction functionality.
Implemented basic cybersecurity responses and input validation.
```

#### GitHub Actions (CI)

- Set up a CI workflow via **GitHub Actions**.
- The workflow should check for syntax errors, code formatting, or a successful build on each push.
- Save the workflow file in `.github/workflows/`.
- Verify the workflow completes successfully (green check mark) before submission.

---

### 9. Video Presentation `[15 Marks]`

- Record a clear, engaging unlisted YouTube video (8–10 minutes).
- Explain your code structure, logic, and techniques used.
- Demonstrate the application running live.
- **Must include your own voice-over — no AI voices.**

---

## Submission Instructions

### ARC Submission

Submit only your **GitHub repository link**, which must include:

- Complete project folder with source code.
- `README.md` with setup instructions and a **screenshot of a successful CI run** (green check mark).
- All multimedia files (WAV file and ASCII art).
- YouTube presentation link.

### GitHub Submission

- Minimum **six commits** with meaningful messages.
- GitHub Actions CI configured and passing.
- WAV file and ASCII art included in the repository.

---

## Marking Rubric — Part 1

### Correct Submission `[5 Marks]`

| Standard          | Description                                                                    | Marks |
| ----------------- | ------------------------------------------------------------------------------ | ----- |
| Does not meet     | Missing required files. No README or instructions.                             | 0–1   |
| Meets             | Contains all required files. README with basic info.                           | 2–3   |
| Partially exceeds | Organised and well-structured. README covers usage and setup.                  | 4     |
| Greatly exceeds   | Clear folder structure, includes README. README includes detailed usage/setup. | 5     |

---

### GitHub and CI Setup `[15 Marks]`

| Standard          | Description                                                                                                                                     | Marks |
| ----------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ----- |
| Does not meet     | No commits made to track changes.                                                                                                               | 0–5   |
| Meets             | Commit messages lack detail and clarity.                                                                                                        | 6–10  |
| Partially exceeds | Includes a good commit history showing progress. GitHub Actions set up for CI but may have minor issues.                                        | 11–13 |
| Greatly exceeds   | Well-documented six commit messages that describe changes clearly. GitHub Actions fully functional, successfully running checks on each commit. | 14–15 |

---

### Voice Greeting and Image Display `[10 Marks]`

| Standard          | Description                                                                                                                                                              | Marks |
| ----------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ----- |
| Does not meet     | No voice greeting or image present. Media files incomplete or missing.                                                                                                   | 0–2   |
| Meets             | A basic voice greeting or ASCII art is included. Implementation is minimal and lacks engagement.                                                                         | 3–5   |
| Partially exceeds | Both a clear voice greeting and engaging ASCII art are included. Media elements work together to create a more immersive experience.                                     | 6–8   |
| Greatly exceeds   | Creative and visually appealing ASCII art, along with high-quality audio. Media elements enhance the user experience significantly, making the chatbot feel interactive. | 9–10  |

---

### Greeting and User Interaction `[10 Marks]`

| Standard          | Description                                                                                                                                                                 | Marks |
| ----------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----- |
| Does not meet     | No personalised greeting provided. User interaction feels robotic and disengaging.                                                                                          | 0–2   |
| Meets             | Basic greeting implemented but lacks personalisation. Limited acknowledgement of user input (e.g., name).                                                                   | 3–5   |
| Partially exceeds | Personalised greetings that engage users and ask for their names. The chatbot responds in a clear and friendly manner.                                                      | 6–8   |
| Greatly exceeds   | Text greeting after ASCII and audio. Highly professional and engaging conversation style. The chatbot consistently personalises responses, creating an inviting atmosphere. | 9–10  |

---

### Basic Response System `[15 Marks]`

| Standard          | Description                                                                                                                         | Marks |
| ----------------- | ----------------------------------------------------------------------------------------------------------------------------------- | ----- |
| Does not meet     | Fails to provide key responses to user queries. Responses are generic and unhelpful.                                                | 0–4   |
| Meets             | The chatbot responds to 2+ basic queries, but the responses lack depth.                                                             | 5–8   |
| Partially exceeds | At least 3 specific and relevant responses are implemented. Responses show an understanding of key topics.                          | 9–12  |
| Greatly exceeds   | Responses cover a wide range of questions with depth and clarity. The conversation feels natural and varied, keeping users engaged. | 13–15 |

---

### Input Validation `[5 Marks]`

| Standard          | Description                                                                                                          | Marks |
| ----------------- | -------------------------------------------------------------------------------------------------------------------- | ----- |
| Does not meet     | No input validation implemented, leading to crashes or errors. The chatbot does not handle invalid input gracefully. | 0–1   |
| Meets             | Basic validation checks are in place, but minimal. General error handling may not cover all edge cases.              | 2–3   |
| Partially exceeds | Comprehensive validation that effectively handles most user inputs. Default responses provided for unknown inputs.   | 4     |
| Greatly exceeds   | Exception handling is graceful and informative, guiding users with helpful messages when errors occur.               | 5     |

---

### Enhanced Console UI `[10 Marks]`

| Standard          | Description                                                                                                                                  | Marks |
| ----------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | ----- |
| Does not meet     | Text output is unstructured and difficult to read. No visual enhancements or formatting present.                                             | 0–2   |
| Meets             | Minimal styling applied to console output; some basic formatting used.                                                                       | 3–5   |
| Partially exceeds | Colour coding and structure are evident, enhancing readability. Visual elements improve user experience but may be inconsistent.             | 6–8   |
| Greatly exceeds   | Polished, well-formatted console UI that is visually appealing. Effective use of colour, borders, and spacing creates an engaging interface. | 9–10  |

---

### Code Structure and Readability `[15 Marks]`

| Standard          | Description                                                                                                                                            | Marks |
| ----------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------ | ----- |
| Does not meet     | Code is poorly organised, making it hard to follow. Lacks basic structure and consistency.                                                             | 0–4   |
| Meets             | Code structure is basic but functional; some effort is made at organisation. Minimal comments provided.                                                | 5–8   |
| Partially exceeds | Code is modular and organised with consistent naming conventions. Some comments provide clarity on function purpose.                                   | 9–12  |
| Greatly exceeds   | Professional structure with good use of methods and classes, and documentation. Full comments/documentation enhance understanding and maintainability. | 13–15 |

---

_© The Independent Institute of Education (Pty) Ltd 2026_
