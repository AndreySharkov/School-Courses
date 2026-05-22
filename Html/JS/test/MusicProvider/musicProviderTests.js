const { expect } = require('chai');
const playSong = require('./musicProvider');

describe('playSong', () => {
    it('1', () => {
        expect(playSong(['Song1'], [], 'Song2')).to.be.undefined;
    });

    it('2', () => {
        let played = ['S1'];
        let res = playSong(['S1', 'S2'], played, 'S2');
        expect(res).to.equal('Played songs: S1, S2');
        expect(played).to.contain('S2');
    });

    it('3', () => {
        expect(playSong(['S1'], ['S1'], 'S1')).to.be.undefined;
    });

    

    it('4', () => {
        expect(playSong(['S1', 'S2'], [], 'S1')).to.be.undefined;
    });

    it('5', () => {
        expect(playSong(['S1', 'S2'], ['S1'], 'S1')).to.be.undefined;
    });

    it('6', () => {
        expect(playSong([], [], 'S1')).to.be.undefined;
    });

    it('7', () => {
        let played = [];
        let res = playSong(['S0', 'S1'], played, 'S1');
        expect(res).to.equal('Played songs: S1');
        expect(played).to.contain('S1');
    });

    it('8', () => {
        let played = ['S1'];
        playSong(['S0', 'S1'], played, 'S1');
        expect(played).to.deep.equal(['S1']);
    });

    it('9', () => {
        expect(playSong(['Song1'], [], 'song1')).to.be.undefined;
    });

    it('10', () => {
        let played = ['S0', 'S1'];
        let res = playSong(['A', 'S0', 'S1', 'S2'], played, 'S2');
        expect(res).to.equal('Played songs: S0, S1, S2');
        expect(played).to.contain('S2');
    });
    it('11', () => {
        expect(playSong(['S0', 'S1'], ['S1'], 'S1')).to.equal('Play On Repeat S1');
    });

    it('12', () => {
        expect(playSong(['S1'], ['S1'], 'S1')).to.be.undefined;
    });

    it('13', () => {
        expect(playSong([],[],'')).to.be.undefined;
    });

});
