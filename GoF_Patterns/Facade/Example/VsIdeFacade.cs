using GoF_Patterns.Facade.Example.Interfaces;

namespace GoF_Patterns.Facade.Example
{
    class VsIdeFacade : IFacade
    {
        private readonly IClr _clr;
        private readonly ICompiler _compiler;
        private readonly ITextEditor _textEditor;
        public VsIdeFacade(IClr clr, ICompiler compiler, ITextEditor editor)
        {
            _clr = clr;
            _compiler = compiler;
            _textEditor = editor;
        }
        public void ActionFirst()
        {
            _textEditor.WriteCode();
            _textEditor.SaveCode();
            _compiler.Compile();
        }

        public void ActionSecond()
        {
            _clr.StartApp();
            _clr.EndApp();
        }
    }
}
