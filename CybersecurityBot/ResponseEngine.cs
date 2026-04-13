// handles all keyword matching and response generation
static class ResponseEngine
{
    // match user input to a relevant cybersecurity response
    public static string GetResponse(string input, string userName)
    {
        // normalise input to lowercase for matching
        string lower = input.ToLower();

        // general chatbot queries
        if (lower.Contains("how are you"))
            return $"I am doing great, {userName}! I am always ready to help you stay safe online. What cybersecurity topic would you like to explore today?";

        if (lower.Contains("purpose") || lower.Contains("what do you do"))
            return $"I am the Cybersecurity Awareness Bot, {userName}. My purpose is to educate South African citizens on common cyber threats and how to stay protected online. I cover topics like phishing, passwords, malware, safe browsing, and more.";

        if (lower.Contains("what can i ask"))
            return $"Great question, {userName}! You can ask me about passwords, phishing, safe browsing, malware, two-factor authentication, and social engineering. Type 'help' for a full list of topics.";

        // cybersecurity topic — passwords
        if (lower.Contains("password"))
            return $"Strong passwords are your first line of defence, {userName}. Use at least 12 characters and mix uppercase letters, lowercase letters, numbers, and special characters. Never reuse the same password across multiple sites. Consider using a reputable password manager to generate and store unique passwords securely.";

        // cybersecurity topic — phishing
        if (lower.Contains("phishing"))
            return $"Phishing scams trick you into revealing sensitive information, {userName}. Always hover over links before clicking to inspect the real URL. Check the sender's email address carefully for misspellings or unusual domains. Never enter passwords or personal details via a link sent in an email — go directly to the official website instead.";

        // cybersecurity topic — safe browsing
        if (lower.Contains("safe browsing"))
            return $"Safe browsing habits greatly reduce your exposure to online threats, {userName}. Always verify that a site uses HTTPS before submitting any personal or financial information. Avoid clicking on unfamiliar or shortened links. Keep your browser and all extensions updated regularly to patch known vulnerabilities.";

        // cybersecurity topic — malware
        if (lower.Contains("malware"))
            return $"Malware is malicious software designed to damage, disrupt, or gain unauthorised access to your device, {userName}. Never download software from untrusted sources, and avoid opening unexpected email attachments. Install a reputable antivirus program and keep it up to date. Back up your important files regularly in case of an infection.";

        // cybersecurity topic — two-factor authentication
        if (lower.Contains("two factor") || lower.Contains("2fa"))
            return $"Two-factor authentication adds a vital second layer of security to your accounts, {userName}. Even if an attacker obtains your password, they cannot access your account without the second factor. Enable 2FA on all important accounts, especially email and banking. Use an authenticator app rather than SMS-based codes where possible, as SMS can be intercepted.";

        // cybersecurity topic — social engineering
        if (lower.Contains("social engineering"))
            return $"Social engineering attacks manipulate people into revealing confidential information, {userName}. Attackers may pose as IT support, a bank representative, or even a colleague. Always verify the identity of anyone requesting sensitive information, especially over the phone or email. Never share passwords or one-time codes with anyone, regardless of who they claim to be.";

        // help command — list all available topics
        if (lower.Contains("help"))
            return $"Here are all the topics I can help you with, {userName}:\n" +
                   "  - Passwords\n" +
                   "  - Phishing\n" +
                   "  - Safe Browsing\n" +
                   "  - Malware\n" +
                   "  - Two-Factor Authentication (type '2fa' or 'two factor')\n" +
                   "  - Social Engineering\n" +
                   "  - How I am doing (type 'how are you')\n" +
                   "  - My purpose (type 'purpose' or 'what do you do')\n" +
                   "  Type 'exit' or 'quit' to end the session.";

        // exit or quit — show farewell before the loop breaks
        if (lower.Trim() == "exit" || lower.Trim() == "quit")
            return $"Stay safe online, {userName}! Thank you for using the Cybersecurity Awareness Bot. Goodbye!";

        // default fallback for unrecognised input
        return $"I didn't quite understand that, {userName}. Could you rephrase? Type 'help' to see available topics.";
    }
}
