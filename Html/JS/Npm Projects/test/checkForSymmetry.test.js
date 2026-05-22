import { expect } from 'chai';
import { isSymmetric } from '../checkForSymmetry.js';

describe('isSymmetric', () => {
    it('should return true for a symmetric array of numbers', () => {
        expect(isSymmetric([1, 2, 2, 1])).to.be.true;
    });

    it('should return true for a symmetric array of strings', () => {
        expect(isSymmetric(['a', 'b', 'b', 'a'])).to.be.true;
    });

    it('should return true for a symmetric array with mixed types', () => {
        expect(isSymmetric([1, 'hello', { a: 1 }, 'hello', 1])).to.be.true;
    });

    it('should return true for an empty array', () => {
        expect(isSymmetric([])).to.be.true;
    });

    it('should return true for an array with a single element', () => {
        expect(isSymmetric([1])).to.be.true;
    });

    it('should return false for a non-symmetric array of numbers', () => {
        expect(isSymmetric([1, 2, 3, 4])).to.be.false;
    });

    it('should return false for a non-symmetric array of strings', () => {
        expect(isSymmetric(['a', 'b', 'c'])).to.be.false;
    });

    it('should return false for a non-array input: number', () => {
        expect(isSymmetric(123)).to.be.false;
    });

    it('should return false for a non-array input: string', () => {
        expect(isSymmetric('hello')).to.be.false;
    });

    it('should return false for a non-array input: object', () => {
        expect(isSymmetric({ a: 1 })).to.be.false;
    });

    it('should return false for a non-array input: null', () => {
        expect(isSymmetric(null)).to.be.false;
    });

    it('should return false for a non-array input: undefined', () => {
        expect(isSymmetric(undefined)).to.be.false;
    });
});
