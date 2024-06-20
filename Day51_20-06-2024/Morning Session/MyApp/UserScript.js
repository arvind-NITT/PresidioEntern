const users = [
    { username: 'arvind', password: '123456' },
    { username: 'user2', password: 'pass2' }
];

function validateLogin(username, password) {
    const user = users.find(user => user.username === username && user.password === password);
    return user ? 'Login successful!' : 'Invalid username or password.';
}

if (typeof module !== 'undefined') {
    module.exports = validateLogin;
}
