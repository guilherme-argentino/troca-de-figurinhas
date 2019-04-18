import Vue from "vue";
import { Component } from "vue-property-decorator";
import axios from 'axios';

@Component
export default class MemberComponent extends Vue {
    deleteMemberId: string = "";
    // $ = JQuery;
    member: member = <member>{
        nome: "",
        login: "",
        senha: ""
    };


    memberList: member[] = [];

    mounted() {
        this.getMemberList();
    }

    getMemberList() {
        axios({
            method: 'get',
            url: 'http://localhost:5000/api/member/getMembersList'
        }).then((response: any) => {
            console.log(response.data);
            this.memberList = response.data;
        }).catch((error: any) => {
            console.log(error);
        });
    }


    addMember() {
        this.member = <member>{
            nome: "",
            login: "",
            senha: "",
        }
    }

}

interface member {
    nome: string;
    login: string;
    senha: string;
    memberId: string;
}