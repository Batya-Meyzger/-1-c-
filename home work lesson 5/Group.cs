using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_lesson_5
{
    public class Group<TMember, TLeader> : IList<TMember>
    {
        public List<TMember> members = new List<TMember>();

        public TLeader? Leader { get; }
        public int MaxOfMembers
        { get; set; }
        public int MinOfMembers
        { get; set; }
        public DateTime Dateopengroup
        { get; set; }
        public Group()
        {

        }
        public Group(TLeader leader, string haedofgroup, int MaxOfMembers, int MinOfMembers, DateTime Dateopengroup)
        {

            this.Leader = leader;
            this.MaxOfMembers = MaxOfMembers;
            this.MinOfMembers = MinOfMembers;
            this.Dateopengroup = Dateopengroup;
        }
        public void Add(TMember member)
        {
            if (members.Count >= MaxOfMembers)
                throw new InvalidOperationException("הקבוצה מלאה!");
            members.Add(member);
        }
        public int Count 
        { get { return members.Count; } }
        
        public bool Contains(TMember member) {
            return members.Contains(member); }

        public int IndexOf(TMember member) {
            return members.IndexOf(member); }

        public bool IsReadOnly
        { get { return false; } }

        public static List<TMember> New { get; private set; }

        public bool Remove(TMember member) 
        { return members.Remove(member); }
        public void RemoveAt(int index) 
        { members.RemoveAt(index); }

        public void Clear() 
        {
            members.Clear();
        }
        public void Copyto(TMember[] array, int arrayIndex)
        {
            members.CopyTo(array, arrayIndex);
        }
        public IEnumerator<TMember> GetEnumerator() 
        { return members.GetEnumerator(); }

        public void Insert(int index, TMember member)
        {
            members.Insert(index, member);
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return members.GetEnumerator();
        }

        public void CopyTo(TMember[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public TMember this[int index]
        {
            get => members[index];
            set => members[index] = value;
        }

    }
}
