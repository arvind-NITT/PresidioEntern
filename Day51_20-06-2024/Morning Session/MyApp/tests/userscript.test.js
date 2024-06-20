const {JSDOM} = require('jsdom');
const fs = require('fs');
const path = require('path');
const validateLogin = require('../UserScript');
describe('Login Validation', () => {
    test('valid username and password should pass', () => {
        expect(validateLogin('arvind', '123456')).toBe('Login successful!');
    });

    test('invalid username should fail', () => {
        expect(validateLogin('invalidUser', 'pass1')).toBe('Invalid username or password.');
    });

    test('invalid password should fail', () => {
        expect(validateLogin('arvind', 'wrongPass')).toBe('Invalid username or password.');
    });

    test('invalid username and password should fail', () => {
        expect(validateLogin('invalidUser', 'wrongPass')).toBe('Invalid username or password.');
    });
});